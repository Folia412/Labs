import scala.language.implicitConversions

trait CommutativeMonoid[A]{
  def union(a1: A, a2: A): A
  def zero: A
}
object CommutativeMonoid{
  implicit val intCommutativeMonoid = new CommutativeMonoid[Set[Int]] {
    override def union(x: Set[Int], y: Set[Int]):
    Set[Int] = x | y
    override val zero = Set()
  }
}
class CommutativeMonoidOps[A](x: A)(implicit g: CommutativeMonoid[A]) {
  def ||(y: A): A = g.union(x, y)
}
object CommutativeMonoidOps {
  implicit def common[A](x: A)(implicit g: CommutativeMonoid[A]): CommutativeMonoidOps[A] = {
    new CommutativeMonoidOps[A](x)
  }
}
