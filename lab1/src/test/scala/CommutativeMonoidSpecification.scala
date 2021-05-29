import org.scalacheck.Properties
import org.scalacheck.Prop.forAll
import CommutativeMonoidOps._

object MonoidSpecification extends Properties("CommutativeMonoid") {
    property("associat1") = forAll {
      (a: Set[Int], b: Set[Int], c: Set[Int]) =>
      var s1 : Set[Int] = (a || b) || c
      var s2 : Set[Int] = a || (b || c)
      s1 == s2
    }
    property("commut1") = forAll {
      (a: Set[Int], b: Set[Int]) =>
      var s1 : Set[Int] = a || b
      var s2 : Set[Int] = b || a
      s1 == s2
    }
    property("identelem1") = forAll {
      (a: Set[Int]) =>
      val z : Set[Int] = CommutativeMonoid.intCommutativeMonoid.zero
      var s1 : Set[Int] = a || z
      var s2 : Set[Int] = z || a
      s1 == a
      s2 == a
    }
}
