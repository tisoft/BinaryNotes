call ../bncompiler.cmd -m java -o output/test -ns org.bn.coders.test_asn -f test.asn
javac -cp ../../../../JavaLibrary/target/binarynotes-${project.version}.jar output/test/*.java
