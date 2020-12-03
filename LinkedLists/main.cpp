#include <iostream>
using namespace std;
//========================================NODETYPE====================================
class NodeType
{
public:
	int info;
	NodeType * next; //points to the next node in the list
	NodeType(int value = 0,
		NodeType *ptr = NULL) 	//default constructor
	{
		info = value;
		next = ptr;
	}
};
//========================================SinglyLinkedList============================
class SinglyLinkedList
{
	NodeType *head;

public:
	SinglyLinkedList() { head = NULL; } //default constructor: creates an empty list
	~SinglyLinkedList(); //destructor: delete all nodes in a list
	void addAtFront(int value); //creates a node with info field set to value
	//adds this newly created node to the front of the list
	void printList();
	void absorb(SinglyLinkedList & second);
	void insert(int value, int position);
	void deleteNode(int position);
	void reverse();
	bool search(int searchInfo);
};
//========================================Functions====================================
SinglyLinkedList::~SinglyLinkedList()
{
	NodeType * ptr = new NodeType();

	ptr = head;

	while (ptr != NULL)
	{
		NodeType * nodeToDelete = ptr;
		ptr = ptr->next;
		delete nodeToDelete;
	}
}

void SinglyLinkedList::addAtFront(int value)
{
	NodeType *ptr = new NodeType(value);
	ptr->next = head;
	head = ptr;
	ptr = NULL; //not needed but safe approach
}

void SinglyLinkedList::printList()
{
	NodeType *current = new NodeType();
	NodeType *previous = NULL;

	current = head;
	// Print list
	while (current != NULL)
	{
		previous = current;
		cout << current->info << " ";
		current = current->next;
	}

	current = NULL;
	previous = NULL;

}

void SinglyLinkedList::absorb(SinglyLinkedList & second)
{
	NodeType *current = new NodeType;
	NodeType *previous = NULL;

	current = head;
	// Navigate to end of list
	while (current->next != NULL)
	{
		previous = current;
		current = current->next;

	}
	// absorb list
	current->next = second.head;

	current = NULL;
	previous = NULL;

}

void SinglyLinkedList::insert(int value, int position)
{
	int tempPos = 0;

	NodeType *current = new NodeType();
	NodeType *previous = NULL;
	NodeType *ptr = new NodeType(value);

	current = head;
	// Insert at head
	if (position == 0)
	{
		ptr->next = current;
		head = ptr;
		current = ptr;
	}

	while (current->next != NULL && tempPos != position)
	{
		previous = current;
		current = current->next;
		tempPos++;
	}
	//Insert at End
	if (tempPos == position && position == 6)
	{
		current->next = ptr;
		current = ptr = NULL;
	}
	// Insert in middle
	if (tempPos == position && position != 0)
	{
		previous->next = ptr;
		ptr->next = current;
	}
	
	previous = current = ptr = NULL;
}

void SinglyLinkedList::deleteNode(int position)
{
	NodeType *current = new NodeType();
	NodeType *previous = NULL;

	current = head;

	int tempPos = 0;
	// Search list
	while (current->next != NULL && tempPos != position)
	{
		previous = current;
		current = current->next;
		tempPos++;
	}
	// Delete at head
	if (current == head)
	{
		head = current->next;
		current->next = NULL;
		delete current;
		current = head;
	}
	// Delete anywhere else
	else
	{
		previous->next = current->next;
		current->next = NULL;
		delete current;
		current = previous->next;
	}
}

bool SinglyLinkedList::search(int searchInfo)
{
	NodeType *current = new NodeType();
	NodeType *previous = NULL;
	NodeType *temp = NULL;

	current = head;
	// Search list
	while (current->info != searchInfo)
	{
		previous = current;
		current = current->next;
	}
	// Move to front of list
	if (current->info == searchInfo)
	{
		previous->next = current->next;
		current->next = head;
		head = current;
	}
	// Return true if found, false if not
	if (current->info == searchInfo)
	{
		return true;
	}
	else
		return false;
}

void  SinglyLinkedList::reverse()
{
	if (head == NULL) return;

	NodeType *previous = NULL, *current = NULL, *next = NULL;
	current = head;
	// Flip the list around
	while (current != NULL)
	{
		next = current->next;
		current->next = previous;
		previous = current;
		current = next;
	}
	//Set head equal to previous pointer
	head = previous;
}
//========================================MAIN========================================
int main()
{
	SinglyLinkedList first, second; //creates an empty list with head set to NULL

	//adding nodes to the list
	first.addAtFront(15);
	first.addAtFront(20);
	first.addAtFront(5);

	cout << "First list: "; first.printList();

	//adding nodes to the list
	second.addAtFront(150);
	second.addAtFront(200);
	second.addAtFront(50);

	cout << endl;
	// Print second list
	cout << "Second list: "; second.printList();
	// Absorb second list into first
	first.absorb(second); cout << endl;
	// Output absorded list
	cout << "Absorbed List: "; first.printList(); cout << endl;
	// Insert new node
	first.insert(77, 4);
	// Output list after insert
	cout << "After inserting new node with value 77: "; first.printList();
	// Delete inserted node
	first.deleteNode(4); cout << endl;
	// Output after deletion
	cout << "After deleting node with value 77: "; first.printList(); cout << endl;

	cout << "Does 50 exist in the list?" << endl;
	// Search for info in nodes
	if (first.search(50))
	{
		cout << "Found 50!" << endl;
		first.printList(); cout << endl;
	}
	else
		cout << "No 50 exists!" << endl;
	// Reverse the list
	first.reverse();
	cout << "Reversed list: "; first.printList(); cout << endl;
	// Pause window
	system("PAUSE");
	// Terminate program
	return 0;
}

