export BUILD_ENV_NEXT_VERSION="0.2.0"

if [[ ! -z "$TRAVIS_TAG" ]]; then 
    echo "TRAVIS_TAG defined to '$TRAVIS_TAG'"
    export BUILD_ENV_PACKAGE_VERSION=$TRAVIS_TAG
else 
    echo "TRAVIS_TAG not defined"
    export BUILD_ENV_PACKAGE_VERSION=$BUILD_ENV_NEXT_VERSION
fi

printenv | grep BUILD_ENV_*