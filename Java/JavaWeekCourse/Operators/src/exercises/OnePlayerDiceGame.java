package exercises;

import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;
 
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
 
public class OnePlayerDiceGame extends JFrame implements ActionListener {
 
    private static final long serialVersionUID = 1L;
 
    /**
     * Creates a random number generator.
     */
    private Random rand = new Random();
 
    /**
     * The text field where the user inputs his bet.
     */
    private JTextField betTextField;
 
    /**
     * Main function.
     * 
     * @param args
     *            Not used.
     */
    public static void main(String[] args) {
        // creates a new instance of the form
        OnePlayerDiceGame form = new OnePlayerDiceGame();
 
        // defines the width and the height of the form
        form.setSize(new Dimension(400, 200));
 
        // centers the from on the screen
        form.setLocationRelativeTo(null);
 
        // the application should be terminated when this form is closed
        form.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
 
        // shows the form
        form.setVisible(true);
    }
 
    /**
     * The form's constructor.
     */
    public OnePlayerDiceGame() {
        // sets the title of the form
        super("One-Player Dice Game");
 
        // sets the layout to be used by the components.
        BoxLayout boxLayout = new BoxLayout(getContentPane(), BoxLayout.Y_AXIS);
        setLayout(boxLayout);
 
        // creates and adds the the label to the form
        add(new JLabel("Enter your bet:"));
 
        // creates and adds the bet text field to the form
        betTextField = new JTextField();
        add(betTextField);
 
        // creates the button, sets the action listener (the form) and adds the
        // button to the form
        JButton rollTheDiceButton = new JButton("Roll the dice");
        rollTheDiceButton.addActionListener(this);
        add(rollTheDiceButton);
    }
 
    /**
     * Called when the button is clicked.
     */
    @Override
    public void actionPerformed(ActionEvent actionEvent) {
 
        // first we get the bet entered by the user.
        String betText = betTextField.getText();
        double bet;
        try {
            bet = Double.parseDouble(betText);
        } catch (NumberFormatException n) {
            // the user has entered an invalid number, so we notify him and
            // abort the operation
            JOptionPane.showMessageDialog(this,
                    "Invalid bet value! Please try again.");
            return;
        }
 
        // roll the dices
        int dice1 = rand.nextInt(6) + 1;
        int dice2 = rand.nextInt(6) + 1;
        int roll = dice1 + dice2;
        
        System.out.println("dice 1: " + dice1 + " dice 2: " + dice2 + " total: " + roll);
        
        // check the results
        if (roll == 7 || roll == 11) {
            // the result was either 7 or 11, so the user wins 3 times the bet
            double total = bet * 3;
            JOptionPane.showMessageDialog(this, "You Won " + total + "!");
        } else {
            // the user lose the game
            JOptionPane.showMessageDialog(this, "You Lose. The roll was "
                    + roll);
        }
    }

}
