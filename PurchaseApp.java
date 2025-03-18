import java.util.Scanner;

public class PurchaseApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Purchase[] purchases = new Purchase[5];

        for (int i = 0; i < purchases.length; i++) {
            int invoiceNumber;
            double amountOfSale;

            do {
                System.out.print("Enter invoice number (1000-8000) for purchase " + (i + 1) + ": ");
                invoiceNumber = scanner.nextInt();
            } while (invoiceNumber < 1000 || invoiceNumber > 8000);

            do {
                System.out.print("Enter sale amount (non-negative) for purchase " + (i + 1) + ": ");
                amountOfSale = scanner.nextDouble();
            } while (amountOfSale < 0);

            purchases[i] = new Purchase(invoiceNumber, amountOfSale);
        }

        System.out.println("\nPurchase Details:");
        for (Purchase purchase : purchases) {
            System.out.println(purchase);
        }

        scanner.close();
    }
}