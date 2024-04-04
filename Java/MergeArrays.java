// Q1: Merge two arrays by satisfying given constraints. Given two sorted arrays X[] and Y[] of size m and n each where m >= n and X[] has exactly n vacant cells, merge elements of Y[] in their correct position in array X[], i.e., merge (X, Y) by keeping the sorted order.

public class MergeArrays {
    public static void mergeArrays(int[] X, int[] Y) {
        int m = X.length;
        int n = Y.length;

        int index = m - 1; 
        int i = m - n - 1; 
        int j = n - 1; 

        while (i >= 0 && j >= 0) {
            if (X[i] > Y[j]) {
                X[index] = X[i];
                i--;
            } else {
                X[index] = Y[j];
                j--;
            }
            index--;
        }

        while (j >= 0) {
            X[index] = Y[j];
            j--;
            index--;
        }
    }
    public static void main(String[] args) {
        int[] X = {0, 2, 0, 3, 0, 5, 6, 0, 0};
        int[] Y = {1, 8, 9, 10, 15};

        mergeArrays(X, Y);

        for (int num : X) {
            System.out.print(num + " ");
        }
    }
}
