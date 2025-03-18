public class BloodData {
    private String bloodType;
    private String rhFactor;

    public BloodData() {
        this.bloodType = "O";
        this.rhFactor = "+";
    }

    public BloodData(String bloodType, String rhFactor) {
        this.bloodType = bloodType;
        this.rhFactor = rhFactor;
    }
    //Getters
    public String getBloodType() {
        return bloodType;
    }

    public String getRhFactor() {
        return rhFactor;
    }

    // SetterS
    public void setBloodType(String bloodType) {
        this.bloodType = bloodType;
    }

    public void setRhFactor(String rhFactor) {
        this.rhFactor = rhFactor;
    }

    public void display() {
        System.out.println("Blood Type: " + bloodType + rhFactor);
    }
}
