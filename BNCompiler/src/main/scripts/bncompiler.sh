#!/bin/sh
BN_HOME=`dirname $0`
java -jar $BN_HOME/bncompiler\-${project.version}.jar $*
