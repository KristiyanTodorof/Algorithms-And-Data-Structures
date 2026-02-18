using BinaryTree;

Node<int> root = new Node<int>(1);
root.left = new Node<int>(2);
root.right = new Node<int>(3);
root.left.left = new Node<int>(4);
root.left.right = new Node<int>(5);
root.right.left = new Node<int>(6);
root.right.right = new Node<int>(7);

TreeTraversal<int> tree = new TreeTraversal<int>();
tree.Order(root);