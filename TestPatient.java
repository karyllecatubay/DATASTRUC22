import java.util.Scanner;

public class TestPatient {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Patient defaultPatient = new Patient();

        // Prompt user for patient details
        System.out.print("\nEnter Patient ID: ");
        int id = scanner.nextInt();
        System.out.print("Enter Patient Age: ");
        int age = scanner.nextInt();
        System.out.print("Enter Blood Type (O, A, B, AB): ");
        String bloodType = scanner.next();
        System.out.print("Enter Rh factor (+ or -): ");
        String rhFactor = scanner.next();

        Patient userPatient = new Patient(id, age, bloodType, rhFactor);

        // Create a third patient with user-defined values but default BloodData
        System.out.print("\nEnter Patient ID (for third patient): ");
        int id3 = scanner.nextInt();
        System.out.print("Enter Age (for third patient): ");
        int age3 = scanner.nextInt();

        Patient thirdPatient = new Patient(id3, age3, "O", "+"); // Default BloodData

        // Display all patients
        System.out.println("\nDefault Patient:");
        defaultPatient.display();
        System.out.println("\nUser-defined Patient:");
        userPatient.display();
        System.out.println("\nThird Patient with default BloodData:");
        thirdPatient.display();

        scanner.close();
    }
}
