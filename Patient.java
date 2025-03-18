public class Patient {
    private int idNumber;
    private int age;
    private BloodData bloodData;

    
    public Patient() {
        this.idNumber = 0;
        this.age = 0;
        this.bloodData = new BloodData(); 
    }

    public Patient(int idNumber, int age, String bloodType, String rhFactor) {
        this.idNumber = idNumber;
        this.age = age;
        this.bloodData = new BloodData(bloodType, rhFactor);
    }

    // Getters
        public int getIdNumber() {
        return idNumber;
    }

    public int getAge() {
        return age;
    }

    public BloodData getBloodData() {
        return bloodData;
    }

    // Setters
        public void setIdNumber(int idNumber) {
        this.idNumber = idNumber;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setBloodData(String bloodType, String rhFactor) {
        this.bloodData.setBloodType(bloodType);
        this.bloodData.setRhFactor(rhFactor);
    }

    public void display() {
        System.out.println("Patient ID: " + idNumber);
        System.out.println("Age: " + age);
        bloodData.display();
    }
}
