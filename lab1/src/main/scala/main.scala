import scala.language.implicitConversions

trait CommutativeMonoid[A]{
  def union(a1: A, a2: A):A
  def sum(a1: A, a2: A):A
}
object CommutativeMonoid{
  implicit val intCommutativeMonoid = new CommutativeMonoid[Set[Int]] {
    override def union(x: Set[Int], y: Set[Int]):
    Set[Int] = x | y
    override def sum(x: Set[Int], y: Set[Int]):
    Set[Int] = x ++ y
  }
}
class CommutativeMonoidOps[A](x: A)(implicit g: CommutativeMonoid[A]) {
  def ||(y: A): A = g.union(x, y)
  def **(y: A): A = g.sum(x, y)
}
object CommutativeMonoidOps {
  implicit def common[A](x: A)(implicit g: CommutativeMonoid[A]): CommutativeMonoidOps[A] = {
    new CommutativeMonoidOps[A](x)
  }
}
    
