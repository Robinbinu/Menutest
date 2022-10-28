#include<stdio.h>
//using namespace std;

void main()
{
    
        //int[] a = new int[20];
        int a[20];
        int n;
        printf("Enter the no of bits:");
        scanf("%d",&n);
        //int n = Convert.ToInt32(Read());
        printf("Enter the binary sequence for parity chk:");
            for (int i = 0; i<n; i++)
            {
                 scanf("%d",&a[i]);   
            }
    //n = a.Length;
    int pb = a[0];

            for(int i=1;i<n;i++)
            {
                pb = pb ^ a[i];
            }
        if (pb == 0)
            printf("The entered binary sequence is of Even Parity \n setting parity bit to 0...\n\n");

        else
            printf("The entered binary sequence is of Odd Parity \n setting parity bit to 1...\n\n");

        printf("Bitsequence with parity bit:");
        printf("%d",pb);
        for (int i = 0; i < n; i++)
        {
            printf("%d",a[i]);
        }

        printf("");

        //return 0;
    }
