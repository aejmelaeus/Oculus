# Hello!

Oculus is used to verify Http connectivity in a system. When running a system that consists of a large number of virtual machines there might be issues with Http connections that are due to infrastructure or firewall configuration problems.

Oculus Nodes can be deployed to machines in the system and Nodes can then be instructed to verify Http connectivity by the Master.

## Master

The master orchestrates the nodes and assigns different roles to them.

## Node

A node is a worker in the system. It is deployed to a computer, ie. virtual machine

## Http Role

A `HttpRole` can be applied to a `Node` in the system. A `HttpRole` has a collection of URL:s it verifies periodicaly and reports to `Master`.

## Bandwidth Role

TODO!