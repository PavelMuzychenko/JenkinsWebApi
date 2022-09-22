pipeline {
    agent any
    stages{
	    stage ('Build') {
	       steps{
 	            git url: 'https://github.com/PavelMuzychenko/JenkinsWebApi.git'
 	            dotnetBuild project: 'C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\RepositoryJenkinsfileWebApi\\SourceWebApi.sln',
 	                sdk: '.NET 6', 
 	                configuration: 'Release'
	       }
	    }
	    stage ('Tests'){
	        steps{
	            dotnetTest project: 'C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\RepositoryJenkinsfileWebApi\\SourceWebApi.sln', 
	                resultsDirectory: 'D:\\Code\\Jenkins\\TargetWebApi\\TestResults', 
	                sdk: '.NET 6', 
	                configuration: 'Release' 
	        }
	    }
	    stage ('Publish'){
	        steps{
	            dotnetPublish project: 'C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\RepositoryJenkinsfileWebApi\\SourceWebApi.sln', 
	                outputDirectory: 'D:\\Code\\Jenkins\\TargetWebApi\\Publish', 
	                sdk: '.NET 6', 
	                configuration: 'Release', 
	                selfContained: false
	        }
	    }
    }
    post {
        always{
            mstest testResultsFile: 'D:\\Code\\Jenkins\\TargetWebApi\\TestResults\\Results.trx'
            emailext subject: 'Build ${JOB_NAME} ${BUILD_NUMBER} has been finished ', 
                body: 'Please go to ${BUILD_URL} and check',
                to: 'Admin@hog', 
                attachLog: true,
                compressLog: true
	    }
    }
}
