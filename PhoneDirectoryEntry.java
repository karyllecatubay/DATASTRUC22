class PhoneDirectoryEntry {
    private String firstName;
    private String phoneNumber;

    public PhoneDirectoryEntry(String firstName, String phoneNumber) {
        this.firstName = firstName;
        this.phoneNumber = phoneNumber;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    @Override
    public String toString() {
        return "Name: " + firstName + ", Phone: " + phoneNumber;
    }
}