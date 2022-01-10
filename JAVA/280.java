import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a = scanner.nextInt();
		int b = scanner.nextInt();
		int c = scanner.nextInt();
		if ((a * a) + (b * b) == (c * c) || (c * c) + (b * b) == (a * a) || (a * a) + (c * c) == (b * b))
			System.out.println("YES");
		else
			System.out.println("NO");
		scanner.close();
	}

}