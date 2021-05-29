scalaVersion := "2.13.5"
scalacOptions += "-language:higherKinds"
addCompilerPlugin("org.typelevel" %% "kind-projector" % "0.11.3" cross CrossVersion.full)

scalacOptions += "-Ydelambdafy:inline"
libraryDependencies ++= Seq(
  "org.scalacheck" %% "scalacheck" % "1.15.4" % "test"
)
scalacOptions ++= Seq(
  "-deprecation",
  "-encoding", "UTF-8",
  "-feature",
  "-unchecked"
)
