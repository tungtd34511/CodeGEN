﻿pipeline {
    agent any
    stages {
        stage('Checkout Code') {
            steps {
                git 'https://github.com/tungtd34511/CodeGEN.git'
            }
        }
        stage('Build') {
            steps {
                echo 'Building the project...'
            }
        }
        stage('Test') {
            steps {
                echo 'Running tests...'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying application...'
            }
        }
    }
}
