import math
class Piste:
    def __init__(self,x,y,z):
        self.x = x
        self.y = y
        self.z = z
    def tulostaPiste(self):
        print('(' + str(self.x) + ', ' + str(self.y) + ', ' + str(self.z) + ')')
    def lisaa(self, piste):
        self.x = self.x + piste.x
        self.y = self.y + piste.y
        self.z = self.z + piste.z
    def vahenna(self, piste):
        self.x = self.x - piste.x
        self.y = self.y - piste.y
        self.z = self.z - piste.z
    def etaisyysOrigosta(self):
        return math.sqrt(self.x^2+self.y^2+self.z^2)
    def kauempana(self, toinen):
        if self.etaisyysOrigosta() < toinen.etaisyysOrigosta():
            return 'true'
        else: return 'false'
    
p1 = Piste(-3,-4,5)
p1.tulostaPiste() 

p2 = Piste(1,1,1)
p1.lisaa(p2)
p1.tulostaPiste() 

p1.vahenna(Piste(3,3,3))
p1.tulostaPiste() 

print(p1.etaisyysOrigosta())

print(p1.kauempana(p2))
