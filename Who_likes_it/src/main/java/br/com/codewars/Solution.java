package br.com.codewars;

import java.util.Map;

public class Solution {
    public static String whoLikesIt(String... names) {
        Integer lenghtOfNames = names.length;
        if (isEmpty(names)) {
            return "no one likes this";
        }
        if (lenghtOfNames == 1) {
            return names[0] + " likes this";
        }
        if (lenghtOfNames == 2) {
            return names[0] + " and " + names[1] + " like this";
        }
        if (lenghtOfNames == 3) {
            return names[0] + ", " + names[1] + " and " + names[2] + " like this";
        }
        return names[0] + ", " + names[1] + " and " + (lenghtOfNames - 2) + " others like this";
    }

    public static boolean isEmpty(String[] s)
    {
        return s.length == 0;
    }
}
