// wwwroot/firebaseInit.js

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getFirestore, collection, addDoc, getDocs } from "firebase/firestore";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {

};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const db = getFirestore(app);
db.collection("users");
const userCol = collection(db , "users")
const snapshot = await getDocs(userCol);

try {
    const docRef = await addDoc(collection(db, "users"), {
        first: "Ada",
        last: "Lovelace",
        born: 1815
    });
    console.log("Document written with ID: ", docRef.id);
} catch (e) {
    console.error("Error adding document: ", e);
}

try {
    const docRef = await addDoc(collection(db, "users"), {
        first: "Alan",
        middle: "Mathison",
        last: "Turing",
        born: 1912
    });

    console.log("Document written with ID: ", docRef.id);
} catch (e) {
    console.error("Error adding document: ", e);
}

/*
window.addUserToFirestore = async function (registrationModel) {
    try {
        // Add the user's registration data to Firestore
        await firebase.firestore().collection('users').add({
            username: registrationModel.username,
            email: registrationModel.email,
            password: registrationModel.password
            // Add other user properties as needed
        });
    } catch (error) {
        console.error("Error adding user to Firestore: ", error);
        throw error;
    }
}*/
