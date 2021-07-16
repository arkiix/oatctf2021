import multiprocessing
import socket

HOST = 'oatctf.ru'
PORT = 6667

def handle(connection, address):
    flag = 'oatctf{3asy_pe4sy_ppc}'
    connection.sendall('>>> '.encode())
    try:
        a = eval(connection.recv(1024).strip().decode())
        connection.sendall(a.encode())
    except:
        pass

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
