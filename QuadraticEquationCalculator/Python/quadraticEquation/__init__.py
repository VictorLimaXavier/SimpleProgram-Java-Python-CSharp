from math import sqrt

class QuadraticEquation:
    def __init__(self, a=0.0, b=0.0, c=0.0):
        if a == 0:
            self.sDelta = 'Δ : '
            self.sResult = "Result : It's not a Quadratic Equation"
        else:
            self.delta = b**2 - (4 * a * c)
            self.sDelta = f'Δ : {self.delta}'
            if self.delta < 0 :
                self.sResult = 'Result : Delta < 0'
            else:
                self.x1 = (- b + sqrt(self.delta))/(2 * a)
                self.x2 = (- b - sqrt(self.delta))/(2 * a)
                self.sResult = f'Result : X1 = {self.x1}; X2 = {self.x2}'
    
    
    def getDelta(self):
        return self.sDelta

    
    def getResult(self):
        return self.sResult
