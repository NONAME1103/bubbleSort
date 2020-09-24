using System;
using static System.Console;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int [] unsorted = new int[] {12, 3, 56, 34, 10, 4, 62, 22};
    Write("Unsorted: ");
    foreach (int num in unsorted) {
      Write (num + " ");
    }
    WriteLine();
    var sorted = bubbleSort(unsorted);
    Write("Sorted: ");
    foreach (int num in sorted) {
      Write (num + " ");
    }
    WriteLine();
  }
  public static int[] bubbleSort(int[] unsorted) {
    for (int passes = 0; passes < (unsorted.Length - 1); passes++) {
      for (int i = 0; i < (unsorted.Length - 1); i++) {
        if (unsorted[i + 1] < unsorted[i]) {
          int small = unsorted[i + 1];
          unsorted[i + 1] = unsorted[i];
          unsorted[i] = small;
        }
      }
    }
    return unsorted;
  }
}