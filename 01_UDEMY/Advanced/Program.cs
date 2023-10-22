using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;


namespace Advanced
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution sol = new Solution();
            string s = "XIX";
            
            Console.WriteLine(sol.RomanToInt(s));
        }
    }
}


public class Solution
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        int sum = 0;
        dictionary.Add('I', 1);
        dictionary.Add('V', 5);
        dictionary.Add('X', 10);
        dictionary.Add('L', 50);
        dictionary.Add('C', 100);
        dictionary.Add('D', 500);
        dictionary.Add('M', 1000);

        int p = 0;
        int value1;
        int value2;
        while (p < s.Length - 1)
        {
            if (dictionary.TryGetValue(s[p], out value1))
            {
                if (dictionary.TryGetValue(s[p + 1], out value2))
                {
                    if (value1 > value2)
                        sum = value1 + value2;
                    else
                        sum = value2 - value1;

                }
            }

            p=+2;
        }

        return sum;
    }
    /// <summary>
    /// Given an array nums of size n, return the majority element.
    /// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
    /// </summary>
    /// <param name="nums">array of numbers</param>
    /// <returns></returns>
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int p = 0;
        while (p < nums.Length)
        {
            int currentCount;
            if (!dictionary.ContainsKey(nums[p]))
                dictionary.Add(nums[p], 1);
            else
            {
                if (dictionary.TryGetValue(nums[p], out currentCount))
                    // increment the current element and then add it, otherwise you will get the same currentValue of 1. 
                    dictionary[nums[p]] = ++currentCount; 
            }
            p++;
        }
        /*
         * Accumulator to get the max key based ont he value in a dictionary 
         * Speed - O(n)
         * https://stackoverflow.com/questions/2805703/good-way-to-get-the-key-of-the-highest-value-of-a-dictionary-in-c-sharp
         */
        return dictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
    }


    /// <summary>
    /// Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.
    /// </summary>
    /// <param name="columnTitle"></param>
    /// <returns></returns>
    public int TitleToNumber(string columnTitle)
    {
        if (!Regex.Match(columnTitle, "^[a-zA-Z]+$").Success)
            throw new ArgumentException("Not Valid");
        columnTitle = columnTitle.ToUpper();
        int sum = 0;
        foreach (var c in columnTitle.ToUpper())
        {
            sum *= 26;
            sum += c - 'A' + 1;
        }

        return sum;
    }


    public int RecursiveFactorial(int number)
    {
        if (number == 1)
            return 1;
        Console.WriteLine(number);
        return number * RecursiveFactorial(number - 1);
    }

    /// <summary>
    /// #206 Reverse Linked List    
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList2(ListNode head)
    {
        return Recursive(head, null, new List<int>());
    }

    public ListNode Recursive(ListNode head, ListNode newHead, List<int> vals)
    {
        if (head == null)
            return newHead;

        var nextNode = head.next;
        head.next = newHead;
        vals.Add(head.val);


        return Recursive(nextNode, head, vals);
    }


    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;

        var firstNode = head;
        var secondNode = firstNode.next;

        while (secondNode != null)
        {
            var temp = secondNode.next;
            secondNode.next = firstNode;
            firstNode = secondNode;
            secondNode = temp;
        }

        head.next = null;
        head = firstNode;
        return head;
    }


    /// <summary>
    /// #371 Sum of Two Integers
    /// Given two integers a and b, return the sum of the two integers without using the operators + and -.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int getSum(int a, int b)
    {
        if (a == 0) return b;
        if (b == 0) return a;

        while (b != 0)
        {
            int carry = a & b; // A and B
            a = a ^ b; // A XOR B
            b = carry << 1;
        }

        return a;
    }


    /// <summary>
    /// MOVE TO ZEROES
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// </summary>
    /// <param name="nums"></param>
    public void MoveZeroesSelf(int[] nums) //O(n)
    {
        int current = 0;
        int next = 1;

        while (next < nums.Length)
        {
            if (nums[current] == 0)
            {
                if (nums[next] != 0)
                {
                    int temp = nums[current];
                    nums[current] = nums[next];
                    nums[next] = temp;
                    current++;
                    next++;
                }
                else
                {
                    next++;
                }
            }
            else
            {
                current++;
                next++;
            }
        }
    }

    public void MoveZeroes(int[] nums) //O(n)
    {
        int current = 0;
        int next = 1;

        while (next < nums.Length)
        {
            if (nums[current] == 0)
            {
                if (nums[next] == 0)
                {
                    next++;
                    continue;
                }
                else
                {
                    nums[current] = nums[next];
                    nums[next] = 0;
                }
            }

            current++;
            next++;
        }
    }

    public void MoveZeroesOnSquare(int[] nums) //O(n^2)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] == 0)
                {
                    nums[j] = nums[j + 1];
                    nums[j + 1] = 0;
                }
            }
        }
    }

    /// <summary>
    /// Using TreeNode Class - Find the max depth of binary tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDeptRecursive(TreeNode root)
    {
        if (root == null)
            return 0;
        return Math.Max(MaxDeptRecursive(root.left), MaxDeptRecursive(root.right)) + 1;
    }

    public int MaxDepthIterative(TreeNode root)
    {
        TreeNode currentNode = root;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(currentNode);

        int left = 1;
        int right = 1;

        if (root == null)
            return 0;

        while (queue.Count > 0)
        {
            currentNode = queue.Dequeue();

            if (currentNode.left != null)
            {
                left++;
                queue.Enqueue(currentNode.left);
            }

            if (currentNode.right != null)
            {
                right++;
                queue.Enqueue(currentNode.right);
            }
        }


        return Math.Max(left, right);
    }


    /// <summary>
    /// Write a function that reverses a string. The input string is given as an array of characters s.
    /// You must do this by modifying the input array in-place with O(1) extra memory.
    /// </summary>
    /// <param name="s"></param>
    public void ReverseString(char[] s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }

    /// <summary>
    /// Given an integer n, return a string array answer (1-indexed) where:
    ///     answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    ///     answer[i] == "Fizz" if i is divisible by 3.
    ///     answer[i] == "Buzz" if i is divisible by 5.
    ///     answer[i] == i(as a string) if none of the above conditions are true.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<string> FizzBuzz(int n)
    {
        List<string> elements = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                elements.Add("FizzBuzz");
            else if (i % 3 == 0)
                elements.Add("Fizz");
            else if (i % 5 == 0)
                elements.Add("Buzz");
            else
                elements.Add(i.ToString());
        }

        return elements;
    }


    public int SingleNumber(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int duplicate = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    nums[j] = 0;
                    nums[i] = 0;
                }
            }
        }

        foreach (var i in nums)
        {
            if (i != 0)
            {
                return i;
            }
        }

        return 0;
    }


    /// <summary>
    /// Bubble Sort Algorithm 
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public int[] BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        return a;
    }

    public int[] SelectionSort(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int highest = i;
            int temp = a[i];
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] > a[highest])
                {
                    highest = j;
                }
            }

            a[i] = a[highest];
            a[highest] = temp;
        }

        return a;
    }
}


/// <summary>
/// Definition for a binary tree node.
/// METHOD: MaxDepthIterative
/// </summary>
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


/// <summary>
/// #206 Reverse Linked List    
/// Definition for listNode 
/// </summary>
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}