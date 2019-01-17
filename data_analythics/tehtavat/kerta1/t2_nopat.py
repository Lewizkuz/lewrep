import random
def Nosixinfour(throwcount):
    s = 0
    tmp = []
    for i in range(throwcount):
        del tmp[:]
        for j in range(4):
            tmp.append(Nopanheitto())
        if 6 not in tmp:
            s = s + 1
    return s

def Nopanheitto():
    return random.randint(1,6)
nosix = 0
i = Nosixinfour(1000000)
print (i)
