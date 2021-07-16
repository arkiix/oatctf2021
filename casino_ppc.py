import multiprocessing
import socket
from random import randint

HOST = "oatctf.ru"
PORT = 777


def handle(connection, address):
    balance = 1000
    connection.sendall(
        'Йоу, рад видеть тебя в нашем казино. Вот твой бонус:\nНа Ваш баланс зачислено 1000$\n'.encode())
    while True:
        connection.sendall('\nВведите Вашу ставку: '.encode())
        try:
            bet = int(connection.recv(1024).strip().decode())
        except:
            connection.sendall('Вы ввели неверную ставку!'.encode())
            continue
        if bet > balance:
            connection.sendall('У Вас нет таких денег!\n'.encode())
            continue
        balance -= bet
        drop = [randint(1, 9) for _ in range(3)]
        connection.sendall(f'Выпало: |{drop[0]}|{drop[1]}|{drop[2]}|\n'.encode())
        check = len(set(drop))
        if check == 1:
            connection.sendall(f'Джекпот! Вы выиграли: {bet * 10}$\n'.encode())
            balance += bet * 10
        elif check == 2:
            connection.sendall(f'Везёт! Вы выиграли: {bet * 3}$\n'.encode())
            balance += bet * 3
        else:
            connection.sendall(f'Повезёт в следующий раз ;(\n'.encode())
        if balance <= 0:
            connection.sendall('Вы проиграли все свои деньги. Всего хорошего.'.encode())
            break
        if balance >= 10000000:
            connection.sendall('oatctf{pos1tive_n3gati0n}'.encode())
            break
        connection.sendall(f'Ваш баланс: {balance}$\n'.encode())


class Server(object):
    def __init__(self, hostname, port):
        self.hostname = hostname
        self.port = port

    def start(self):
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.socket.bind((self.hostname, self.port))
        self.socket.listen(10)

        while True:
            conn, address = self.socket.accept()
            process = multiprocessing.Process(
                target=handle, args=(conn, address))
            process.daemon = True
            process.start()

if __name__ == "__main__":
    server = Server(HOST, PORT)
    print('Start server...')
    try:
        server.start()
        print('Yes!')
    except:
        print('Error!!!')
    finally:
        for process in multiprocessing.active_children():
            process.terminate()
            process.join()
    print('Shutdown server...')
