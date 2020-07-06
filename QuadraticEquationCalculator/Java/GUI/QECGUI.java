package gui;
import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JPanel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.BorderLayout;
import quadraticEquation.QuadraticEquation;

public class QECGUI extends JFrame implements ActionListener{
    private static final long serialVersionUID = 1L;
    private JTextField txtA, txtB, txtC;
    private JLabel lblA, lblB, lblC, lblDelta, lblResult;
    private JButton btnOk;
    private JPanel pnlEq, pnlDelta, pnlResult;
    private Container container;

    public QECGUI (){
        super("Quadratic Equation Calculator");

        container = getContentPane();
        container.setLayout(new BorderLayout());


        txtA = new JTextField("0", 3);
        txtA.setHorizontalAlignment(JTextField.RIGHT);
        txtB = new JTextField("0", 3);
        txtB.setHorizontalAlignment(JTextField.RIGHT);
        txtC = new JTextField("0", 3);
        txtC.setHorizontalAlignment(JTextField.RIGHT);

        lblA = new JLabel(" x²  + ");
        lblB = new JLabel(" x  + ");
        lblC = new JLabel(" =  0 ");

        btnOk = new JButton("Ok");

        lblDelta = new JLabel("Δ : ");
        lblResult = new JLabel("Result : ");

        pnlEq = new JPanel(new FlowLayout(FlowLayout.LEADING));
        pnlEq.add(txtA);
        pnlEq.add(lblA);
        pnlEq.add(txtB);
        pnlEq.add(lblB);
        pnlEq.add(txtC);
        pnlEq.add(lblC);
        pnlEq.add(btnOk);

        pnlDelta = new JPanel(new FlowLayout(FlowLayout.LEADING));
        pnlDelta.add(lblDelta);

        pnlResult = new JPanel(new FlowLayout(FlowLayout.LEADING));
        pnlResult.add(lblResult);

        container.add(pnlEq, BorderLayout.NORTH);
        container.add(pnlDelta, BorderLayout.CENTER);
        container.add(pnlResult, BorderLayout.SOUTH);

        btnOk.addActionListener(this);

        setSize(300, 130);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
        
     }

     public void actionPerformed(ActionEvent e){
        if(e.getSource() == btnOk){
            try{
                double a = Double.parseDouble(txtA.getText());
                double b = Double.parseDouble(txtB.getText());
                double c = Double.parseDouble(txtC.getText());
                QuadraticEquation qe = new QuadraticEquation(a, b, c);
                lblDelta.setText(qe.getSDelta());
                lblResult.setText(qe.getSResult());
            }catch(Exception ex){
                lblResult.setText("Result : Invalid Values!");
            }
        }
     }
}
