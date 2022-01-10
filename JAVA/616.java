//package library;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		long a = scanner.nextLong();
		long i = 2;
		while(i<=a)
			i*=2;
		System.out.println(i);
	}
}