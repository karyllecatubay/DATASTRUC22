public class Main{
   public static void main(String []args){
      Sandwich sandwich = new Sandwich();
      
      sandwich.setBreadType("wheat");
      sandwich.setMainIngredient("egg");
      sandwich.setPrice(50);
      
      System.out.println(sandwich.getBreadType());
      System.out.println(sandwich.getMainIngredient());
      System.out.println(sandwich.getPrice());      
   }
}