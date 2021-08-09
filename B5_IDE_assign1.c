#include<stdio.h>
#include<stdlib.h>
void enq(int);
void deq();
void display();
void push(int);
void pop1();
void pop2();
int n, stack1[50], stack2[50];
int top1=0, top2=0;
void main()
{
    int i,x,val;
    printf("\n 221810305039 - Varshita.N\n");
    printf("\nEnter the size of the queue:");
    scanf("%d",&n);
    printf("\n1.Enqueue  2.Dequeue  3.Display  4.exit\n");
    while(1)
    {
        printf("\nEnter your choice:"); 
        scanf("%d",&x);
        switch(x)
        {
            case(1):printf("\nEnter the value:");
                    scanf("%d",&val);
                    enq(val);
                    break;
            case(2):deq();
                    break;
            case(3):display();
                    break;
            case(4): exit(0);
        }   
    }
}
void push(int v)
{
    if(top1==n)
    {
        printf("The queue is full \n");
    }
    else
    {
        stack1[top1]=v;
        top1++;
    }
}
void enq(int val)
{
    push(val);
}
void pop1()
{
    int i;
    if(top1==0)
    {
        printf("Queue is empty");
    }
    else
    {
        while(top1>0)
        {
        stack2[top2]=stack1[top1];
        top2++;
        top1--;
        }
        top2--;
        pop2();
    }
}

void pop2()
{
    int i;
    while(top2>0)
    {
    stack1[top1]=stack2[top2];
    top1++;
    top2--;
    }
}

void deq()
{
    pop1();
}
void display()
{
    int i;
    if(top1==0)
    {
        printf("Queue is empty");
    }
    for(i=0;i<top1;i++)
    {
        printf("%d\t",stack1[i]);
    }
}