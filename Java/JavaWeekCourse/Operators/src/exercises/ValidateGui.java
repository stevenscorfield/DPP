package exercises;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import exercises.Solution;

public class ValidateGui {
	JFrame mainFrame;
	JPanel panel;
	JButton btValidate;
	JTextArea unText;
	String result;
	
	public ValidateGui() {
		
    	mainFrame = new JFrame("Password Validation Programme - Alex Kennedy");
    	mainFrame.setLayout(new FlowLayout());
    	mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    	mainFrame.setSize(420,80);
    	mainFrame.setLocationRelativeTo(null);
    	panel = new JPanel();
    	panel.setSize(420,80);
    	unText = new JTextArea("", 1,10);
    	
    	
    	
    	btValidate = new JButton("Validate");
    	btValidate.setMnemonic('V');
    	btValidate.addActionListener(new ActionListener() {
    		public void actionPerformed(ActionEvent arg0){
    			result = Solution.check(unText.getText());
        		if (result == "PASS") {
        			JOptionPane.showMessageDialog(null, "Your username reach the complexity requirements");
        		} else if (result == "FAIL"){
       				JOptionPane.showMessageDialog(null, "Your username did not meet the requirements");
       			}
    		}
    	});
    	
    	mainFrame.add(panel);
    	panel.add(unText);
    	mainFrame.add(btValidate);
    	mainFrame.setVisible(true);
	}
}
