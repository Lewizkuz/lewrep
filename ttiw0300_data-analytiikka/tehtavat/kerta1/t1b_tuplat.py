def Poistup(sana):
    sana = sana.lower()
    tmp = []
    for kirj in sana:
        if kirj not in tmp:
            tmp.append(kirj)
    return ''.join(tmp)
print Poistup("AnaNasakäämä")
print Poistup("Saippuakauppias")
print Poistup("Floridalainen broileri")
