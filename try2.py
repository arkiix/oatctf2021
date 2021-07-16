import multiprocessing
import socket
from random import randint

HOST = 'oatctf.ru'
PORT = 6668

def handle(connection, address):
    flag = 'oatctf{y0u_kn0w_y0ur_bus1n3s5}'

    try:
        b = randint(5, 50)
        connection.sendall('>>> '.encode())
        a = eval(connection.recv(1024).strip().decode())
        if len(a) == len(flag) + b and 'list' in str(type(a)):
            connection.sendall(str(a).encode())
        else:
            connection.sendall('Fail!'.encode())
    except:
        connection.sendall('Error!'.encode())

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
