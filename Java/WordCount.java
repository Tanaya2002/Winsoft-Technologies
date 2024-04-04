// Q3:Write a Java Program to count the number of words in a string using HashMap.

import java.util.HashMap;

public class WordCount {
    public static void main(String[] args) {
        String str = "Hello world, this is a test string. Hello again!";
        
        str = str.replaceAll("[^a-zA-Z ]", "").toLowerCase();
        
        String[] words = str.split("\\s+");
        
        HashMap<String, Integer> wordCountMap = new HashMap<>();
        
        for (String word : words) {
            if (wordCountMap.containsKey(word)) {
                wordCountMap.put(word, wordCountMap.get(word) + 1);
            } else {
                wordCountMap.put(word, 1);
            }
        }
        
        System.out.println("Word count:");
        for (String word : wordCountMap.keySet()) {
            System.out.println(word + ": " + wordCountMap.get(word));
        }
    }
}
