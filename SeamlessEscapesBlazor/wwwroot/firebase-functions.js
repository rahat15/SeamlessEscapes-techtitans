window.firebaseFunctions = {
    signInWithEmailAndPassword: function (email, password) {
        return firebase.auth().signInWithEmailAndPassword(email, password)
            .then(userCredential => userCredential.user)
            .catch(error => {
                console.error("Error signing in:", error);
                throw error;
            });
    },
    signOut: function () {
        return firebase.auth().signOut()
            .then(() => console.log("Signed out successfully"))
            .catch(error => {
                console.error("Error signing out:", error);
                throw error;
            });
    },
    // Add more functions as needed
};
