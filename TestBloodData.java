import java.util.Scanner;

public class TestBloodData {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter blood type (O, A, B, AB): ");
        String bloodType = scanner.next();
        System.out.print("Enter Rh factor (+ or -): ");
        String rhFactor = scanner.next();

        BloodData userBloodData = new BloodData(bloodType, rhFactor);
        BloodData defaultBloodData = new BloodData();

        System.out.println("\nDefault Blood Data:");
        defaultBloodData.display();
        System.out.println("\nUser Blood Data:");
        userBloodData.display();

        defaultBloodData.setBloodType(bloodType);
        defaultBloodData.setRhFactor(rhFactor);

        System.out.println("\nUpdated Default Blood Data:");
        defaultBloodData.display();

        scanner.close();
    }
}
