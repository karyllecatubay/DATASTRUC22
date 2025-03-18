import java.util.ArrayList;
import java.util.Scanner;

public class PhoneDirectoryApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<PhoneDirectoryEntry> directory = new ArrayList<>();

        // Pre-fill the directory with 10 entries
        for (int i = 1; i <= 10; i++) {
            directory.add(new PhoneDirectoryEntry("Person" + i, "123-456-789" + i));
        }

        while (true) {
            System.out.print("Enter a name to search (or 'quit' to exit): ");
            String inputName = scanner.nextLine();

            if (inputName.equalsIgnoreCase("quit")) {
                System.out.println("Exiting the program.");
                break;
            }

            boolean found = false;
            for (PhoneDirectoryEntry entry : directory) {
                if (entry.getFirstName().equalsIgnoreCase(inputName)) {
                    System.out.println("Phone number for " + inputName + ": " + entry.getPhoneNumber());
                    found = true;
                    break;
                }
            }

            if (!found) {
                if (directory.size() >= 30) {
                    System.out.println("Directory is full. Cannot add new entries.");
                    break;
                }

                System.out.print("Name not found. Enter phone number for " + inputName + ": ");
                String phoneNumber = scanner.nextLine();
                directory.add(new PhoneDirectoryEntry(inputName, phoneNumber));
                System.out.println("Added " + inputName + " to the directory.");
            }
        }

        // Display all entries in the directory
        System.out.println("\nFinal Directory:");
        for (PhoneDirectoryEntry entry : directory) {
            System.out.println(entry);
        }

        scanner.close();
    }
}