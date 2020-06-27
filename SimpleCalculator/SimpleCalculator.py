result = 0
while True:
    try:
        n1 = float(input('Enter the first number: '))
        break
    except:
        print('Invalid value!')
while True:
    sign = str(input('Enter the sign( + , - , * , / ): ')).strip()[0]
    if sign in '+-*/':
        break
    print('Invalid value!')
while True:
    try:
        n2 = float(input('Enter the second number: '))
        break
    except:
        print('Invalid value!')
if(sign == '+'):
    result = n1 + n2
elif(sign == '-'):
    result = n1 - n2
elif(sign == '*'):
    result = n1 * n2
elif(sign == '/'):
    result = n1 * n2
print(f"{n1} {sign} {n2} = {result}")
