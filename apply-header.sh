#!/bin/bash

for i in `find ./TornApiProxy/ -iname "*.cs"`
do
  if ! grep -q Copyright $i
  then
    cat license_header.txt $i > $i.new && mv $i.new $i
  fi
done
