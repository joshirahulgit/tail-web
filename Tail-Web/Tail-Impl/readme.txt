This project implements Tail-Spec project.

Each time Follow method is called, It starts pooling file using a seperate thread. Make sure to call Unfollow method to stop and close thread safely.