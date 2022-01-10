
import java.util.Scanner;

public class Main {
	
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();
		for(int i = n;i>1;i--)
			n*= i-1;
		System.out.println(n);
		scanner.close();
	}
	
}