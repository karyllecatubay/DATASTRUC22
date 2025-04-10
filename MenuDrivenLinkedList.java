import java.util.Scanner;

class Node {
    int data;
    Node next;
}

public class MenuDrivenLinkedList {
    static Node head = null;

    // Insert at beginning
    public static void insertAtBeginning(int value) {
        Node newNode = new Node();
        newNode.data = value;
        newNode.next = head;
        head = newNode;
        System.out.println("Inserted: " + value);
    }

    // Delete at beginning
    public static void deleteAtBeginning() {
        if (head == null) {
            System.out.println("List is empty.");
        } else {
            System.out.println("Deleted: " + head.data);
            head = head.next;
        }
    }

    // Display all elements
    public static void display() {
        if (head == null) {
            System.out.println("List is empty.");
            return;
        }

        Node temp = head;
        System.out.print("List: ");
        while (temp != null) {
            System.out.print(temp.data + " -> ");
            temp = temp.next;
        }
        System.out.println("null");
    }

    // Search for a value
    public static void search(int key) {
        Node temp = head;
        while (temp != null) {
            if (temp.data == key) {
                System.out.println("Found: " + key);
                return;
            }
            temp = temp.next;
        }
        System.out.println("Not found: " + key);
    }

    // Delete a specific element
    public static void deleteByValue(int value) {
        if (head == null) {
            System.out.println("List is empty.");
            return;
        }

        if (head.data == value) {
            head = head.next;
            System.out.println("Deleted: " + value);
            return;
        }

        Node prev = head;
        Node curr = head.next;

        while (curr != null) {
            if (curr.data == value) {
                prev.next = curr.next;
                System.out.println("Deleted: " + value);
                return;
            }
            prev = curr;
            curr = curr.next;
        }

        System.out.println("Value not found: " + value);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int choice, value;

        do {
            System.out.println("\nMENU");
            System.out.println("0. Terminate the Program");
            System.out.println("1. Insert an Element (Beginning)");
            System.out.println("2. Delete an Element (Beginning)");
            System.out.println("3. Display All Elements");
            System.out.println("4. Search an Element");
            System.out.println("5. Delete an Element");
            System.out.print("Choose an option: ");
            choice = sc.nextInt();

            switch (choice) {
                case 0:
                    System.out.println("Goodbye!");
                    break;
                case 1:
                    System.out.print("Enter value to insert: ");
                    value = sc.nextInt();
                    insertAtBeginning(value);
                    break;
                case 2:
                    deleteAtBeginning();
                    break;
                case 3:
                    display();
                    break;
                case 4:
                    System.out.print("Enter value to search: ");
                    value = sc.nextInt();
                    search(value);
                    break;
                case 5:
                    System.out.print("Enter value to delete: ");
                    value = sc.nextInt();
                    deleteByValue(value);
                    break;
                default:
                    System.out.println("Invalid choice. Try again.");
            }
        } while (choice != 0);

        sc.close();
    }
}
