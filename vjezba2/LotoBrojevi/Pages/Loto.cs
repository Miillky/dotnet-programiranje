using System;
using System.Collections.Generic;

namespace LotoBrojevi.Pages {
  public static class Loto {
    public static SortedSet<int> GenerateNumbers(int quantity, int max) {
      SortedSet<int> numbers = new SortedSet<int>();

      while (numbers.Count < quantity) {
        numbers.Add(new Random().Next() % max + 1);
      }

      return numbers;
    }
  }
}