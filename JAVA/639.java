package library;

import java.util.Scanner;

import javax.swing.text.AbstractDocument.BranchElement;

public class Main {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = new String[scanner.nextInt()];
		for (int i = 0; i  input.length; i++)
			input[i] = scanner.next();
		String commonString = new String();
		for (int i = 0; i  input[0].length(); i++)
			for (int j = i; j  input[0].length(); j++) {
				String string = input[0].substring(i, j + 1);
				if (string.length()  commonString.length())
					for (int n = 0; n  input.length; n++)
						if (checkContains(string, input))
							commonString = string;
			}

		if (commonString.length()  0)
			System.out.println(commonString);
	}
	static String reverce(char[] input) {
		for (int i = 0; i  input.length  2; i++) {
			char temp = input[i];
			input[i] = input[input.length - 1 - i];
			input[input.length - 1 - i] = temp;
		}
		return String.valueOf(input);
	}

	static boolean checkContains(String common, String[] strings) {
		for (int i = 0; i  strings.length; i++)
			if (!strings[i].contains(common) && !strings[i].contains(reverce(common.toCharArray())))
				return false;
		return true;
	}
}