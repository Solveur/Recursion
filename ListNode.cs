namespace Recursion
{
	public class ListNode<T>
	{
		public T Value;
		public ListNode<T>? next;
		public ListNode(T value, ListNode<T>? next = null)
		{
			Value = value;
			this.next = next;
		}
	}
}