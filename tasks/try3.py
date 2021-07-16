flag = 'oatctf{fake_flag}'
a = input()
if 'flag' not in a:
    try:
        print(eval(a))
    except:
        print('Error!')
else:
    print('You cannot call the flag!')