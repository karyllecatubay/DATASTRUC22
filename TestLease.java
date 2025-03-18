import java.util.Scanner;

public class TestLease {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Declare Lease objects
        Lease lease1 = getData(scanner);
        Lease lease2 = getData(scanner);
        Lease lease3 = getData(scanner);
        Lease lease4 = new Lease(); // Uses default constructor values

        // Display initial values
        System.out.println("\nInitial lease details:");
        showValues(lease1);
        showValues(lease2);
        showValues(lease3);
        showValues(lease4);

        // Apply pet fee to lease1
        System.out.println("\nAdding pet fee to lease1...");
        lease1.addPetFee();

        // Show updated values for lease1
        System.out.println("\nUpdated lease1 details:");
        showValues(lease1);

        // Confirm all leases
        System.out.println("\nFinal lease details:");
        showValues(lease1);
        showValues(lease2);
        showValues(lease3);
        showValues(lease4);

        scanner.close();
    }

    // Method to get user input and create a Lease object
    public static Lease getData(Scanner scanner) {
        Lease lease = new Lease();

        System.out.print("\nEnter tenant name: ");
        lease.setTenantName(scanner.nextLine());

        System.out.print("Enter apartment number: ");
        lease.setApartmentNumber(scanner.nextInt());

        System.out.print("Enter monthly rent amount: ");
        lease.setRent(scanner.nextDouble());

        System.out.print("Enter lease term in months: ");
        lease.setLeaseTerm(scanner.nextInt());

        scanner.nextLine(); // Consume the newline character

        return lease;
    }

    // Method to display lease details
    public static void showValues(Lease lease) {
        System.out.println("\nTenant Name: " + lease.getTenantName());
        System.out.println("Apartment Number: " + lease.getApartmentNumber());
        System.out.println("Monthly Rent: $" + lease.getRent());
        System.out.println("Lease Term: " + lease.getLeaseTerm() + " months");
    }
}