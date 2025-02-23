import Customer.Customer;

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Customer[] customers = new Customer[10];
        customers[0] = new Customer("Иванов", "Иван", "Иванович", 1001);
        customers[1] = new Customer("Петров", "Петр", "Петрович", 1002);
        customers[2] = new Customer("Сидоров", "Сергей", "Александрович", 1003);
        customers[3] = new Customer("Козлова", "Анна", "Владимировна", 1004);
        customers[4] = new Customer("Смирнов", "Алексей", "Дмитриевич", 1005);
        customers[5] = new Customer("Александрова", "Ольга", "Игоревна", 1006);
        customers[6] = new Customer("Морозов", "Дмитрий", "Сергеевич", 1007);
        customers[7] = new Customer("Васильева", "Екатерина", "Андреевна", 1008);
        customers[8] = new Customer("Новиков", "Андрей", "Николаевич", 1009);
        customers[9] = new Customer("Федорова", "Мария", "Викторовна", 1010);
        //sortCustomer(customers);
        Arrays.sort(customers);
        System.out.println("---------------------------Вывод отсортированного массимва по фамилии---------------------------");
        for (var customer : customers) {
            System.out.println(customer.show());
        }

        System.out.println("---------------------------Вывод покупателе, входящие в интервал---------------------------");
        int from = 1000;
        int to = 1004;
        for (var customer : customers) {
            if(customer.isInInterval(from, to)) {
                System.out.println(customer.show());
            }
        }
    }

    public static void sortCustomer(Customer[] customers) {
        int n = customers.length;
        boolean swapped;
        for (int i = 0; i < n - 1; i++) {
            swapped = false;
            for (int j = 0; j < n - 1 - i; j++) {
                if (customers[j].isLastNameMore(customers[j + 1])) {
                    Customer temp = customers[j];
                    customers[j] = customers[j + 1];
                    customers[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}
