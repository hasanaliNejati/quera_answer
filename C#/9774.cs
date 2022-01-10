//package library;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		long a = scanner.nextLong();
		long b = a;
		int i;
		for (i = 0; b > 0; i++) {
			b /= 10;
		}
		b = a;
		long[] numbers = new long[i];
		for (int ii = 0; ii < numbers.length; ii++) {
			numbers[ii] = b % 10;
			b /= 10;
		}
		for (int ii = numbers.length - 1; ii >= 0; ii--) {
			String out = new String();
			out = numbers[ii] + ": ";
			for (int iii = 0; iii < numbers[ii]; iii++)
				out += numbers[ii];
			System.out.println(out);
		}
	}

}