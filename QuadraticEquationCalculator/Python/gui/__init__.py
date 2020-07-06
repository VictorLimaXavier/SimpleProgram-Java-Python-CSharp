from tkinter import Tk, Label, Button, Entry
from quadraticEquation import QuadraticEquation

class QECGUI:

    def __init__(self, master):
        self.master = master
        master.title('Quadratic Equation Calculator')
        
        self.entry_a = Entry(master, width=5, justify='right')
        self.entry_a.grid(row=0, column=0)

        lbl_a = Label(master, text=' x² + ')
        lbl_a.grid(row=0, column=1)

        self.entry_b = Entry(master, width=5, justify='right')
        self.entry_b.grid(row=0, column=2)
        
        lbl_b = Label(master, text=' x + ')
        lbl_b.grid(row=0, column=3)

        self.entry_c = Entry(master, width=5, justify='right')
        self.entry_c.grid(row=0, column=4)
        
        lbl_c = Label(master, text=' = 0')
        lbl_c.grid(row=0, column=5)

        self.lbl_delta = Label(master, text='Δ : ')
        self.lbl_delta.grid(row=1, columnspan=6, sticky='w')

        self.lbl_result = Label(master, text='Result : ')
        self.lbl_result.grid(row=2, columnspan=6, sticky='w')

        self.btn_ok = Button(master, text=' Ok ', command=self.ok)
        self.btn_ok.grid(row=0, column=6)

    def ok(self):
        try:
            a = float(self.entry_a.get())
            b = float(self.entry_b.get())
            c = float(self.entry_c.get())
            qe = QuadraticEquation(a, b, c)
            self.lbl_delta['text'] = qe.getDelta()
            self.lbl_result['text'] = qe.getResult()
            
        except:
            self.lbl_result['text'] = 'Result : Invalid Value!'
