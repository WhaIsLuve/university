package Customer;

public class Customer implements Comparable<Customer> {
    private String lastName;
    private String firstName;
    private String middleName;
    private int cardNumber;

    public Customer(String lastName, String firstName, String middleName, int cardNumber) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.middleName = middleName;
        this.cardNumber = cardNumber;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getMiddleName() {
        return middleName;
    }

    public void setMiddleName(String middleName) {
        this.middleName = middleName;
    }

    public int getCardNumber() {
        return cardNumber;
    }

    public void setCardNumber(int cardNumber) {
        this.cardNumber = cardNumber;
    }

    public boolean isFirstNameMore(Customer customer) {
        return this.firstName.compareTo(customer.firstName) > 0;
    }

    public boolean isLastNameMore(Customer customer) {
        return this.lastName.compareTo(customer.lastName) > 0;
    }

    public boolean isMiddleNameMore(Customer customer) {
        return this.middleName.compareTo(customer.middleName) > 0;
    }

    public boolean isInInterval(int from, int to) {
        return this.cardNumber > from && this.cardNumber < to;
    }

    public String show() {
        return "----Customer----" +
                '\n' +
                getLastName() +
                '\n' +
                getFirstName() +
                '\n' +
                getMiddleName() +
                '\n' +
                getCardNumber() +
                '\n';
    }

    @Override
    public int compareTo(Customer o) {
        return this.lastName.compareTo(o.lastName);
    }
}
