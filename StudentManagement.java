
import java.util.ArrayList;
import java.util.Scanner;

class Student {
    private String id;
    private String firstName;
    private String lastName;
    private String course;
    private int yearLevel;

    public Student(String id, String firstName, String lastName, String course, int yearLevel) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.course = course;
        this.yearLevel = yearLevel;
    }

    public String getId() {
        return id;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getCourse() {
        return course;
    }

    public int getYearLevel() {
        return yearLevel;
    }

    @Override
    public String toString() {
        return "ID: " + id + ", Name: " + firstName + " " + lastName + ", Course: " + course + ", Year Level: " + yearLevel;
    }
}

public class StudentManagement {
    private static final int MAX_STUDENTS = 100;
    private static ArrayList<Student> students = new ArrayList<>();
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int choices;
        do {
            System.out.println("\nStudent Management System");
            System.out.println("\n1. Add New Student");
            System.out.println("2. Display All Students");
            System.out.println("3. Display All Students in Reverse");
            System.out.println("0. Exit/Terminate Program");
            System.out.print("\nEnter your choice: ");
            choices = scanner.nextInt();
            scanner.nextLine(); 

            switch (choices) {
                case 1:
                    addStudent();
                    break;
                case 2:
                    displayStudents();
                    break;
                case 3:
                    displayStudentsReverse();
                    break;
                case 0:
                    System.out.println("Exiting the program...");
                    break;
                default:
                    System.out.println("Invalid choice! Try again.");
            }
        } while (choices != 0);
    }

    private static void addStudent() {
        if (students.size() >= MAX_STUDENTS) {
            System.out.println("Maximum limit reached. Cannot add more students.");
            return;
        }

        System.out.print("\nStudent ID: ");
        String id = scanner.nextLine();
        System.out.print("First Name: ");
        String firstName = scanner.nextLine();
        System.out.print("Last Name: ");
        String lastName = scanner.nextLine();
        System.out.print("Course: ");
        String course = scanner.nextLine();
        System.out.print("Year Level: ");
        int yearLevel = scanner.nextInt();
        scanner.nextLine(); 

        Student student = new Student(id, firstName, lastName, course, yearLevel);
        students.add(student);
        System.out.println("Student added successfully!");
    }

    private static void displayStudents() {
        if (students.isEmpty()) {
            System.out.println("No records found.");
            return;
        }

        System.out.println("\nStudent Records:");
        for (Student student : students) {
            System.out.println(student);
        }
    }

    private static void displayStudentsReverse() {
        if (students.isEmpty()) {
            System.out.println("No records found.");
            return;
        }

        System.out.println("\nStudent Records in Reverse:");
        for (int i = students.size() - 1; i >= 0; i--) {
            System.out.println(students.get(i));
        }
    }
}