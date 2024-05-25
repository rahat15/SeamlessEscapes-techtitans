// wwwroot/firebaseInit.js

function loadScript(src) {
    return new Promise((resolve, reject) => {
        const script = document.createElement('script');
        script.src = src;
        script.onload = resolve;
        script.onerror = reject;
        document.head.appendChild(script);
    });
}

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyAwA69lCh74JXtd0OTtrS04EGMjxKs_I7o",
    authDomain: "seamless-escapes-ad561.firebaseapp.com",
    projectId: "seamless-escapes-ad561",
    storageBucket: "seamless-escapes-ad561.appspot.com",
    messagingSenderId: "31572445099",
    appId: "1:31572445099:web:45c30ffd463edf5bae74ee",
    measurementId: "G-Q4WX4VXB40"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);

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
}