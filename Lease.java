public class Lease {
    private String tenantName;
    private int apartmentNumber;
    private double rent;
    private int leaseTerm;

    // Default constructor
    public Lease() {
        this.tenantName = "XXX";
        this.apartmentNumber = 0;
        this.rent = 1000;
        this.leaseTerm = 12;
    }

    // Getters and setters
    public String getTenantName() {
        return tenantName;
    }

    public void setTenantName(String tenantName) {
        this.tenantName = tenantName;
    }

    public int getApartmentNumber() {
        return apartmentNumber;
    }

    public void setApartmentNumber(int apartmentNumber) {
        this.apartmentNumber = apartmentNumber;
    }

    public double getRent() {
        return rent;
    }

    public void setRent(double rent) {
        this.rent = rent;
    }

    public int getLeaseTerm() {
        return leaseTerm;
    }

    public void setLeaseTerm(int leaseTerm) {
        this.leaseTerm = leaseTerm;
    }

    // Method to add pet fee
    public void addPetFee() {
        this.rent += 10;
        explainPetPolicy();
    }

    // Static method to explain pet fee policy
    public static void explainPetPolicy() {
        System.out.println("A pet fee of $10 has been added to the rent.");
    }
}