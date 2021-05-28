import org.scalacheck.Prop.forAll
import org.scalacheck.{Arbitrary, Gen, Prop}
import scala.language.implicitConversions

trait CommutativeMonoid[A]{
  def union(a1:A, a2:A):A
  def sum(a1:A, a2: A):A
}
object CommutativeMonoid{
  implicit val intCommutativeMonoid = new CommutativeMonoid[Set[Int]] {
    override def union(x: Set[Int], y: Set[Int]):
    Set[Int] = x | y
    override def sum(x: Set[Int], y: Set[Int]):
    Set[Int] = x ++ y
  }
}
class CommutativeMonoids[A: CommutativeMonoid](x: A)(implicit g: CommutativeMonoid[A]) {
  def ||(y: A): A = g.union(x, y)
  
  def **(y: A): A = g.sum(x, y)
}
object Mono1 {
  def main(args: Array[String]): Unit = {
    implicit def common[A](x: A)(implicit g: CommutativeMonoid[A]): CommutativeMonoids[A] = {
      new CommutativeMonoids[A](x)
    }
       
    val associat1 = forAll { 
      (a: Set[Int], b: Set[Int], c: Set[Int]) =>
      var s1 : Set[Int] = (a || b) || c
      var s2 : Set[Int] = a || (b || c)
      s1 == s2     
    }
    val commut1 = forAll {
      (a: Set[Int], b: Set[Int]) =>
      var s1 : Set[Int] = a || b
      var s2 : Set[Int] = b || a
      s1 == s2    
    }
    val identelem1 = forAll {
      (a: Set[Int]) =>
      var b : Set[Int] = Set()
      var s1 : Set[Int] = a || b
      var s2 : Set[Int] = b || a
      s1 == a
      s2 == a
    }
    val associat2 = forAll { 
      (a: Set[Int], b: Set[Int], c: Set[Int]) =>
      var s1 : Set[Int] = (a ** b) ** c
      var s2 : Set[Int] = a ** (b ** c)
      s1 == s2     
    }
    val commut2 = forAll {
      (a: Set[Int], b: Set[Int]) =>
      var s1 : Set[Int] = a ** b
      var s2 : Set[Int] = b ** a
      s1 == s2    
    }
    val identelem2 = forAll {
      (a: Set[Int]) =>
      var b : Set[Int] = Set()
      var s1 : Set[Int] = a ** b
      var s2 : Set[Int] = b ** a
      s1 == a
      s2 == a
    }
    associat1.check()
    
    commut1.check()
    
    identelem1.check()
    
    associat2.check()
    
    commut2.check()
    
    identelem2.check()
  }
}
    
    
