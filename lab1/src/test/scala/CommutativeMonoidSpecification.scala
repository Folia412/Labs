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
      var b : Set[Int] = Set()
      var s1 : Set[Int] = a || b
      var s2 : Set[Int] = b || a
      s1 == a
      s2 == a
    }
    property("associat2") = forAll {
      (a: Set[Int], b: Set[Int], c: Set[Int]) =>
      var s1 : Set[Int] = (a ** b) ** c
      var s2 : Set[Int] = a ** (b ** c)
      s1 == s2
    }
    property("commut2") = forAll {
      (a: Set[Int], b: Set[Int]) =>
      var s1 : Set[Int] = a ** b
      var s2 : Set[Int] = b ** a
      s1 == s2
    }
    property("identelem2") = forAll {
      (a: Set[Int]) =>
      var b : Set[Int] = Set()
      var s1 : Set[Int] = a ** b
      var s2 : Set[Int] = b ** a
      s1 == a
      s2 == a
    }
}
